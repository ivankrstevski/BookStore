import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AuthorComponent } from './author.component';
import { AuthorDetailsComponent } from './author-details/author-details.component';
import { AuthorEditComponent } from './author-edit/author-edit.component';

const routes = [
  { path: '', component: AuthorComponent },
  { path: ':id', component: AuthorDetailsComponent },
  { path: ':id/edit', component: AuthorEditComponent }
]

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})
export class AuthorRoutingModule { }
