import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { JsonpModule } from '@angular/http';
import { HttpClientModule, HttpResponse } from '@angular/common/http';

import { ModalModule } from 'ngx-bootstrap';
import { NgxPaginationModule } from 'ngx-pagination';

import { ClientRoutingModule } from './client-routing.module';
import { ClientComponent } from './client.component';

import { AbpModule } from '@abp/abp.module';

import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';
import { SharedModule } from '@shared/shared.module';

import { UserRegistrationComponent } from 'client/users/user-registration/user-registration';
import { ClientFooterComponent } from 'client/layout/client-footer.component';
import { ClientHeaderComponent } from 'client/layout/client-header.component';



@NgModule({
    declarations: [
        ClientComponent,
        ClientHeaderComponent,
        ClientFooterComponent,
        UserRegistrationComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        JsonpModule,
        ModalModule.forRoot(),
        AbpModule,
        ClientRoutingModule,
        ServiceProxyModule,
        SharedModule,
        NgxPaginationModule
    ],
    providers: [

    ]
})
export class ClientModule { }
