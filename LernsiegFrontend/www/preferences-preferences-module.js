(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["preferences-preferences-module"],{

/***/ "082A":
/*!***********************************************************!*\
  !*** ./src/app/preferences/preferences-routing.module.ts ***!
  \***********************************************************/
/*! exports provided: PreferencesPageRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PreferencesPageRoutingModule", function() { return PreferencesPageRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "iInd");
/* harmony import */ var _preferences_page__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./preferences.page */ "qk+q");




const routes = [
    {
        path: '',
        component: _preferences_page__WEBPACK_IMPORTED_MODULE_3__["PreferencesPage"]
    }
];
let PreferencesPageRoutingModule = class PreferencesPageRoutingModule {
};
PreferencesPageRoutingModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]],
    })
], PreferencesPageRoutingModule);



/***/ }),

/***/ "5kK8":
/*!***************************************************!*\
  !*** ./src/app/preferences/preferences.page.scss ***!
  \***************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJwcmVmZXJlbmNlcy5wYWdlLnNjc3MifQ== */");

/***/ }),

/***/ "KqXm":
/*!***************************************************!*\
  !*** ./src/app/preferences/preferences.module.ts ***!
  \***************************************************/
/*! exports provided: PreferencesPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PreferencesPageModule", function() { return PreferencesPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "SVse");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "s7LF");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "sZkV");
/* harmony import */ var _preferences_routing_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./preferences-routing.module */ "082A");
/* harmony import */ var _preferences_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./preferences.page */ "qk+q");
/* harmony import */ var _shared_shared_module__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../shared/shared.module */ "PCNd");
/* harmony import */ var _core_core_module__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ../core/core.module */ "pKmL");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @angular/common/http */ "IheW");
/* harmony import */ var _ionic_storage_angular__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @ionic/storage-angular */ "jSNZ");
/* harmony import */ var _core_storage_service__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ../core/storage.service */ "qRYv");












let PreferencesPageModule = class PreferencesPageModule {
};
PreferencesPageModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["IonicModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_9__["HttpClientModule"],
            _preferences_routing_module__WEBPACK_IMPORTED_MODULE_5__["PreferencesPageRoutingModule"],
            _shared_shared_module__WEBPACK_IMPORTED_MODULE_7__["SharedModule"],
            _core_core_module__WEBPACK_IMPORTED_MODULE_8__["CoreModule"],
            _ionic_storage_angular__WEBPACK_IMPORTED_MODULE_10__["IonicStorageModule"].forRoot()
        ],
        declarations: [_preferences_page__WEBPACK_IMPORTED_MODULE_6__["PreferencesPage"]],
        providers: [_core_storage_service__WEBPACK_IMPORTED_MODULE_11__["StorageService"]]
    })
], PreferencesPageModule);



/***/ }),

/***/ "LJR/":
/*!*****************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/preferences/preferences.page.html ***!
  \*****************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<ion-header>\n  <ion-toolbar>\n    <ion-title>Einstellungen</ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content [fullscreen]=\"true\">\n  <ion-header collapse=\"condense\">\n    <ion-toolbar>\n      <ion-title size=\"large\">Einstellungen</ion-title>\n    </ion-toolbar>\n  </ion-header>\n\n  <div id=\"container\">\n    <ion-item>\n      <ion-label>Benutzername:</ion-label>\n      <ion-input [(ngModel)]=\"userName\"></ion-input>\n    </ion-item>\n\n    <ion-item>\n      <ion-label>UserId:</ion-label>\n      <ion-input type=\"number\" [(ngModel)]=\"userId\"></ion-input>\n    </ion-item>\n\n    <ion-item>\n      <ion-label>Passwort:</ion-label>\n      <ion-input type=\"password\" [(ngModel)]=\"password\"></ion-input>\n    </ion-item>\n\n    <ion-button (click)=\"login()\">Anmelden</ion-button>\n    <ion-button (click)=\"logout()\">Abmelden</ion-button>\n  </div>\n</ion-content>\n\n\n<ion-footer>\n  <ion-toolbar>\n    <navbar></navbar>\n  </ion-toolbar>\n</ion-footer>");

/***/ }),

/***/ "pKmL":
/*!*************************************!*\
  !*** ./src/app/core/core.module.ts ***!
  \*************************************/
/*! exports provided: CoreModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CoreModule", function() { return CoreModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "SVse");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "IheW");
/* harmony import */ var _ionic_storage_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/storage-angular */ "jSNZ");
/* harmony import */ var _storage_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./storage.service */ "qRYv");






let CoreModule = class CoreModule {
};
CoreModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        declarations: [],
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClientModule"],
            _ionic_storage_angular__WEBPACK_IMPORTED_MODULE_4__["IonicStorageModule"].forRoot()
        ],
        exports: [_storage_service__WEBPACK_IMPORTED_MODULE_5__["StorageService"]],
        providers: [_storage_service__WEBPACK_IMPORTED_MODULE_5__["StorageService"]]
    })
], CoreModule);



/***/ }),

/***/ "qk+q":
/*!*************************************************!*\
  !*** ./src/app/preferences/preferences.page.ts ***!
  \*************************************************/
/*! exports provided: PreferencesPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PreferencesPage", function() { return PreferencesPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _raw_loader_preferences_page_html__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! raw-loader!./preferences.page.html */ "LJR/");
/* harmony import */ var _preferences_page_scss__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./preferences.page.scss */ "5kK8");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "sZkV");
/* harmony import */ var _core_storage_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../core/storage.service */ "qRYv");






let PreferencesPage = class PreferencesPage {
    constructor(storageService, toastController) {
        this.storageService = storageService;
        this.toastController = toastController;
        this.userName = '';
        this.userId = null;
        this.password = '';
    }
    ngOnInit() {
    }
    ngAfterViewInit() {
    }
    login() {
        console.log(this.storageService);
        this.user = { userName: this.userName, userId: this.userId, password: this.password };
        if (this.user) {
            this.storageService.set('currentUser', this.user);
            this.presentToast(`User ${this.user.userName} | ${this.user.userId} logged in`);
        }
    }
    logout() {
        this.storageService.get('currentUser').then((x) => {
            if (x != null) {
                this.storageService.remove('currentUser');
                this.presentToast(`User ${this.user.userName} | ${this.user.userId} logged out`);
            }
            else {
                this.presentToast(`No User logged in`);
            }
        });
    }
    presentToast(message) {
        return Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"])(this, void 0, void 0, function* () {
            const toast = yield this.toastController.create({
                message: message,
                duration: 2000
            });
            toast.present();
        });
    }
};
PreferencesPage.ctorParameters = () => [
    { type: _core_storage_service__WEBPACK_IMPORTED_MODULE_5__["StorageService"] },
    { type: _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["ToastController"] }
];
PreferencesPage = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_3__["Component"])({
        selector: 'app-preferences',
        template: _raw_loader_preferences_page_html__WEBPACK_IMPORTED_MODULE_1__["default"],
        styles: [_preferences_page_scss__WEBPACK_IMPORTED_MODULE_2__["default"]]
    })
], PreferencesPage);



/***/ })

}]);
//# sourceMappingURL=preferences-preferences-module.js.map