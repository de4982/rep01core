import { Component, ViewContainerRef, Injector, OnInit, AfterViewInit } from '@angular/core';
import { AppConsts } from '@shared/AppConsts';
import { AppComponentBase } from '@shared/app-component-base';

import { SignalRHelper } from '@shared/helpers/SignalRHelper';
import { SignalRAspNetCoreHelper } from '@shared/helpers/SignalRAspNetCoreHelper';

@Component({
    templateUrl: './client.component.html'
})
export class ClientComponent extends AppComponentBase implements OnInit, AfterViewInit {

    private viewContainerRef: ViewContainerRef;

    constructor(
        injector: Injector
    ) {
        super(injector);
    }

    ngOnInit(): void {
        
        
    }

    ngAfterViewInit(): void {
        
    }
}