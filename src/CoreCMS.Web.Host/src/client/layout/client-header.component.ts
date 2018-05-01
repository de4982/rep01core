import { Component, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
    selector: 'client-header',
    templateUrl: './client-header.component.html'
})
export class ClientHeaderComponent extends AppComponentBase {


    constructor(
        injector: Injector
    ) {
        super(injector);
    }

}
