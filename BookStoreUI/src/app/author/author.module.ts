import { NgModule } from '@angular/core';

import { AuthorComponent } from './author.component';
import { AuthorEditComponent } from './author-edit/author-edit.component';
import { AuthorDetailsComponent } from './author-details/author-details.component';
import { AuthorRoutingModule } from './author-routing.module';

@NgModule({
  imports: [AuthorRoutingModule],
  declarations: [AuthorComponent, AuthorEditComponent, AuthorDetailsComponent]
})
export class AuthorModule { }
