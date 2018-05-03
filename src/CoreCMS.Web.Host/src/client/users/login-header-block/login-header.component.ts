import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { UserServiceProxy, UserDto, RoleDto } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';
import { AppSessionService } from 'shared/session/app-session.service';

@Component({
    selector: 'login-header',
    templateUrl: './login-header.component.html'
})
export class LoginHeaderComponent extends AppComponentBase {

    authenticated: boolean = false;

    constructor(
        injector: Injector,
        private _userService: UserServiceProxy,
        private _sessionService: AppSessionService,
    ) {
        super(injector);
        this.authenticated = typeof this._sessionService.user !== "undefined" && this._sessionService.user !== null;
    }

    
}
