import { NgModule } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { TranslateModule } from '@ngx-translate/core';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

import { AuthorComponent } from './author.component';
import { AuthorEditComponent } from './author-edit/author-edit.component';
import { AuthorDetailsComponent } from './author-details/author-details.component';
import { AuthorRoutingModule } from './author-routing.module';

export function HttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http);
}

@NgModule({
  imports: [
    AuthorRoutingModule,
    TranslateModule,
    BsDatepickerModule.forRoot(),
  ],
  declarations: [
    AuthorComponent,
    AuthorEditComponent,
    AuthorDetailsComponent
  ],
  exports: [TranslateModule]
})
export class AuthorModule { }
