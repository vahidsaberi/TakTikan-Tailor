import {Component, Injector} from '@angular/core';
// import {ActivatedRoute} from '@angular/router';
// import {AppConsts} from '@shared/AppConsts';
import {appModuleAnimation} from '@shared/animations/routerTransition';
import {AppComponentBase} from '@shared/common/app-component-base';

@Component({
    templateUrl: './fabricroll.component.html',
    animations: [appModuleAnimation()]
})

export class FabricRollComponent extends AppComponentBase {
    
    constructor(
        injector: Injector
    ) {
        super(injector);
    }
}