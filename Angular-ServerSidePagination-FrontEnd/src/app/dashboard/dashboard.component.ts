import { Component, OnInit } from '@angular/core';
import { IGetRowsParams } from 'ag-grid-community/dist/lib/interfaces/iDatasource';
import {
  AgGridEvent,
  ILoadingCellRendererParams,
  GridOptions,
} from 'ag-grid-community';

import { UserService } from './services/user.service';
import { GetAllUserResponseModel } from './models/getAllUserResponseModel.model';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
})
export class DashboardComponent implements OnInit {
  private readonly columnDefs: {}[];
  private readonly defaultColDef: {
    resizable: boolean;
    lockPosition: boolean;
    sortable: boolean;
  };

  private readonly cacheOverflowSize: number;
  private readonly components: {};

  public gridOptions: GridOptions;

  constructor(private userService: UserService) {
    this.cacheOverflowSize = 2;

    this.defaultColDef = {
      resizable: true,
      lockPosition: true,
      sortable: true,
    };

    this.columnDefs = [
      {
        headerName: 'Id',
        field: 'id',
        minWidth: 55,
        maxWidth: 55,
        cellRenderer: 'loadingRenderer',
      },
      {
        headerName: 'First name',
        field: 'firstName',
        minWidth: 250,
        maxWidth: 360,
      },
      {
        headerName: 'Last name',
        field: 'lastName',
        minWidth: 250,
        maxWidth: 360,
      },
      {
        headerName: 'Email address',
        field: 'email',
        minWidth: 200,
        maxWidth: 550,
      },
      {
        headerName: 'Gender',
        field: 'gender',
        minWidth: 90,
        maxWidth: 90,
      },
      {
        headerName: 'Company',
        field: 'company',
        minWidth: 300,
        maxWidth: 350,
      },
    ];

    this.components = {
      loadingRenderer: function (params: ILoadingCellRendererParams) {
        if (params.value) {
          return params.value;
        } else {
          return '<img src="./assets/loading.gif">';
        }
      },
    };
  }

  ngOnInit(): void {
    this.gridOptions = {
      headerHeight: 45,
      rowHeight: 30,
      paginationPageSize: 90,
      rowModelType: 'infinite',
      pagination: true,
      columnDefs: this.columnDefs,
      defaultColDef: this.defaultColDef,
      cacheOverflowSize: this.cacheOverflowSize,
      components: this.components,
    };
  }

  public onFirstDataRendered(params: AgGridEvent): void {
    params.api.sizeColumnsToFit();
  }

  public onGridReady(params: AgGridEvent): void {
    const dataSource = {
      getRows: (params: IGetRowsParams) => {
        this.userService.getUsers(params).subscribe(
          (response: GetAllUserResponseModel) => {
            params.successCallback(response.users, response.totalRecords);
          },
          (err) => {
            console.log(err);
          }
        );
      },
    };

    params.api.setDatasource(dataSource);
  }
}
