import {Component, ElementRef, Injector, ViewChild, ViewEncapsulation, AfterViewInit} from '@angular/core';
import {appModuleAnimation} from '@shared/animations/routerTransition';
import {AppComponentBase} from '@shared/common/app-component-base';
import { Paginator } from 'primeng/paginator';
import { Table } from 'primeng/table';
import { LazyLoadEvent } from 'primeng/api';
import { GenderServiceProxy } from '@shared/service-proxies/service-proxies';
import { AbpSessionService } from 'abp-ng2-module';
import { Router } from '@angular/router';

@Component({
    templateUrl: './gender.component.html',
    encapsulation: ViewEncapsulation.None,
    animations: [appModuleAnimation()]
})

export class GenderComponent extends AppComponentBase implements AfterViewInit {
    
    @ViewChild('gendersTable', {static: true}) gendersTable: ElementRef;
    @ViewChild('dataTable', {static: true}) dataTable: Table;
    @ViewChild('paginator', {static: true}) paginator: Paginator;

    sourceNames: string[] = [];
    sourceName: string;
    targetValueFilter: string;
    filterText: string;

    constructor(
        injector: Injector,
        private _genderService: GenderServiceProxy,
        private _sessionService: AbpSessionService,
        private _router: Router
    ) {
        super(injector);
    }

    ngAfterViewInit(): void {

    }

    getGenders(event?: LazyLoadEvent) {
        if (!this.paginator || !this.dataTable || !this.sourceName) {
            return;
        }

        this.primengTableHelper.showLoadingIndicator();

        this._genderService.getAllGender()
    }
}