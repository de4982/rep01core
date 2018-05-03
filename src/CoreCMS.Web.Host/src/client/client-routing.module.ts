import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ClientComponent } from 'client/client.component';


@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: 'client',
                component: ClientComponent,
                children: [
                    //{ path: 'home', component: HomeComponent, canActivate: [AppRouteGuard] },                    
                    //{ path: 'registration', component: UserRegistrationComponent }
                ]
            }
        ])
    ],
    exports: [RouterModule]
})
export class ClientRoutingModule { }