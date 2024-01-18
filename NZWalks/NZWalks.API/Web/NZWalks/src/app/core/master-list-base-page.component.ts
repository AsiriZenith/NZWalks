import { Observable, Subject, switchMap } from 'rxjs';
import { RxState } from '@rx-angular/state';
import { MasterListViewModel } from './master-list-view-model';
import { MasterListService } from './master-list-service';

export abstract class MasterListBasePageComponent<
  Entity,
  State extends MasterListViewModel<Entity> = MasterListViewModel<Entity>
> {
  constructor(
    protected state: RxState<State>,
    protected listService: MasterListService<Entity>
  ) {
    // Connect the state
    this.state.connect('list', this.list$);
  }
  // Injections

  // User Events
  getAll = new Subject<boolean>();
  delete = new Subject<string>();

  // View Model
  vm$: Observable<State> = this.state.select();

  // get all entities
  list$ = this.getAll.pipe(switchMap(() => this.listService.getAll()));

  // delete entity
  delete$ = this.delete.pipe(
    switchMap((id) => this.listService.delete(id)),
    switchMap(() => this.listService.getAll())
  );
}
