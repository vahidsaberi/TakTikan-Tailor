import { NgModule } from '@angular/core';
import { NavigationEnd, Router, RouterModule } from '@angular/router';

import { FabricTypeComponent } from './fabrictype/fabrictype.component';
import { FabricMaterialComponent } from './fabricmaterial/fabricmaterial.component';
import { FabricCutComponent } from './fabriccut/fabriccut.component';
import { GenderComponent } from './gender/gender.component';
import { SeamstressComponent } from './seamstress/seamstress.component';
import { SalineStoneComponent } from './salinestone/salinestone.component';
import { FabricRollComponent } from './fabricroll/fabricroll.component';
import { SewnPieceComponent } from './sewnpiece/sewnpiece.component';
import { SalineStoneOrderComponent } from './salinestoneorder/salinestoneorder.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                children: [
                    { path: 'fabricType', component: FabricTypeComponent, data: { permission: 'Pages.TakTikan.FabricType' } },
                    { path: 'fabricMaterial', component: FabricMaterialComponent, data: { permission: 'Pages.TakTikan.' } },
                    { path: 'fabricCut', component: FabricCutComponent , data: { permission: 'Pages.TakTikan.FabricCut' } },
                    { path: 'gender', component: GenderComponent, data: { permission: 'Pages.TakTikan.Gender' } },
                    { path: 'seamstress', component: SeamstressComponent, data: { permission: 'Pages.TakTikan.Seamstress' } },
                    { path: 'salineStone', component: SalineStoneComponent, data: { permission: 'Pages.TakTikan.SalineStone' } },
                    { path: 'fabricRoll', component: FabricRollComponent, data: { permission: 'Pages.TakTikan.FabricRoll' } },
                    { path: 'sewnPiece', component: SewnPieceComponent, data: { permission: 'Pages.TakTikan.SewnPiece' } },
                    { path: 'salineStoneOrder', component: SalineStoneOrderComponent, data: { permission: 'Pages.TakTikan.SalineStoneOrder' } },

                    { path: '', redirectTo: 'hostDashboard', pathMatch: 'full' },
                    { path: '**', redirectTo: 'hostDashboard' }
                ]
            }
        ])
    ],
    exports: [
        RouterModule
    ]
})
export class TakTikanRoutingModule {

    constructor(
        private router: Router
    ) {
        router.events.subscribe((event) => {
            if (event instanceof NavigationEnd) {
                window.scroll(0, 0);
            }
        });
    }
}
