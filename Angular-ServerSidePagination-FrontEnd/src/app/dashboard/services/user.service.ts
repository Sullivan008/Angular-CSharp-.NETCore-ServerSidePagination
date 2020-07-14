import { IGetRowsParams } from 'ag-grid-community/dist/lib/interfaces/iDatasource';
import { GetAllUserResponseModel } from '../models/getAllUserResponseModel.model';
import { Observable } from 'rxjs/internal/Observable';
import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class UserService {
  constructor(private http: HttpClient) {}

  public getUsers(params: IGetRowsParams): Observable<GetAllUserResponseModel> {
    return this.http.post<GetAllUserResponseModel>(
      'http://localhost:2175/api/User/GetAllUser',
      params
    );
  }
}
