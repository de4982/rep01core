import { Component, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
    selector: 'client-footer',
    templateUrl: './client-footer.component.html'
})
export class ClientFooterComponent extends AppComponentBase {

    
    constructor(
        injector: Injector
    ) {
        super(injector);
    }
    
}
