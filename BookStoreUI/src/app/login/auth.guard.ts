import { Injectable } from '@angular/core';
import {
  CanActivate, CanLoad,
  ActivatedRouteSnapshot,
  RouterStateSnapshot, UrlTree,
  Router, Route, UrlSegment
} from '@angular/router';
import { Observable } from 'rxjs';

import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate, CanLoad {

  constructor(private authService: AuthService,
    private router: Router) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot):
    boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
    return this.checkLoggedIn(state.url);
  }

  canLoad(route: Route, segments: UrlSegment[]): boolean {
    return this.checkLoggedIn(segments.join('/'));
  }

  checkLoggedIn(url: string): boolean {
    if (this.authService.isLoggedIn) {
      return true;
    }

    this.router.navigate(['/login']);
    return false;
  }
}
