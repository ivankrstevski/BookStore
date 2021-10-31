import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AuthGuard } from './login/auth.guard';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes = [
  {
    path: 'authors',
    canActivate: [AuthGuard],
    loadChildren: () => import('./author/author.module').then(m => m.AuthorModule)
  },
  { path: '**', component: PageNotFoundComponent }
]

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
