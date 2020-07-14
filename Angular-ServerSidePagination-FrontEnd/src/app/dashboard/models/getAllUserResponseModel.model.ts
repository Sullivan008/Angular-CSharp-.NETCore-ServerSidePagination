import { User } from './user.model';

export class GetAllUserResponseModel {
  public users: User[];
  public totalRecords: number;
}
