import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class CanDeactivateGuard implements CanDeactivate<any> {

  canDeactivate() {
    return true;
  }

}
