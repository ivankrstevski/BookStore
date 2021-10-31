import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  currentUser: any;

  get isLoggedIn(): boolean {
    return true;
  }

  constructor() { }

  login(userName: string, password: string): void {
    //TODO
  }

  logout(): void {
    this.currentUser = null;
  }
}
