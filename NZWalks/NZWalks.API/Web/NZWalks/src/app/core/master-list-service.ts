import { Observable } from 'rxjs';

export interface MasterListService<Entity> {
  getAll(): Observable<Entity[]>;
  delete(id: string): Observable<Entity>;
}
