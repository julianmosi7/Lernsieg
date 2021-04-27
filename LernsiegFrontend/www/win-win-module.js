(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["win-win-module"],{

/***/ "HsNj":
/*!***********************************!*\
  !*** ./src/app/win/win.page.scss ***!
  \***********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJ3aW4ucGFnZS5zY3NzIn0= */");

/***/ }),

/***/ "I7vi":
/*!*************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/win/win.page.html ***!
  \*************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<ion-header>\n  <ion-toolbar>\n    <ion-title>Gewinne</ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content [fullscreen]=\"true\">\n  <ion-header collapse=\"condense\">\n    <ion-toolbar>\n      <ion-title size=\"large\">Gewinne</ion-title>\n    </ion-toolbar>\n  </ion-header>\n\n  <div id=\"container\">\n    <ion-card>\n      <ion-list>\n        <div *ngFor=\"let w of wins; let i = index\">\n          <ion-item>\n            <ion-label>{{i+3}}er:</ion-label>\n            <ion-label>{{w}}</ion-label>\n          </ion-item>\n        </div>\n        <ion-item>\n          <ion-label>Gesamtgewinn:</ion-label>\n          <ion-label>{{win.total}}</ion-label>\n        </ion-item>\n      </ion-list>\n    </ion-card>\n\n    <ion-button (click)=\"load()\">Load Wins</ion-button>\n  </div>\n</ion-content>\n\n<ion-footer>\n  <ion-toolbar>\n    <navbar></navbar>\n  </ion-toolbar>\n</ion-footer>");

/***/ }),

/***/ "WSLa":
/*!*********************************!*\
  !*** ./src/app/win/win.page.ts ***!
  \*********************************/
/*! exports provided: WinPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WinPage", function() { return WinPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _raw_loader_win_page_html__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! raw-loader!./win.page.html */ "I7vi");
/* harmony import */ var _win_page_scss__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./win.page.scss */ "HsNj");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _core_lotto_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../core/lotto.service */ "28ja");
/* harmony import */ var _core_storage_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../core/storage.service */ "qRYv");






let WinPage = class WinPage {
    constructor(lottoService, storageService) {
        this.lottoService = lottoService;
        this.storageService = storageService;
        this.wins = [];
        this.win = { nr3: 0, nr4: 0, nr5: 0, nr6: 0, total: 0, status: '', msg: '' };
    }
    ngOnInit() {
    }
    load() {
        this.storageService.get('currentUser').then(x => {
            this.wins = [];
            if (x != null) {
                this.lottoService.getWinsOfUser(x.userId, x.password).subscribe(y => {
                    this.wins.push(y.nr3);
                    this.wins.push(y.nr4);
                    this.wins.push(y.nr5);
                    this.wins.push(y.nr6);
                    this.win = y;
                });
            }
        });
    }
};
WinPage.ctorParameters = () => [
    { type: _core_lotto_service__WEBPACK_IMPORTED_MODULE_4__["LottoService"] },
    { type: _core_storage_service__WEBPACK_IMPORTED_MODULE_5__["StorageService"] }
];
WinPage = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_3__["Component"])({
        selector: 'app-win',
        template: _raw_loader_win_page_html__WEBPACK_IMPORTED_MODULE_1__["default"],
        styles: [_win_page_scss__WEBPACK_IMPORTED_MODULE_2__["default"]]
    })
], WinPage);



/***/ }),

/***/ "gC2w":
/*!*******************************************!*\
  !*** ./src/app/win/win-routing.module.ts ***!
  \*******************************************/
/*! exports provided: WinPageRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WinPageRoutingModule", function() { return WinPageRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "iInd");
/* harmony import */ var _win_page__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./win.page */ "WSLa");




const routes = [
    {
        path: '',
        component: _win_page__WEBPACK_IMPORTED_MODULE_3__["WinPage"]
    }
];
let WinPageRoutingModule = class WinPageRoutingModule {
};
WinPageRoutingModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]],
    })
], WinPageRoutingModule);



/***/ }),

/***/ "oDwQ":
/*!***********************************!*\
  !*** ./src/app/win/win.module.ts ***!
  \***********************************/
/*! exports provided: WinPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WinPageModule", function() { return WinPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "SVse");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "s7LF");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "sZkV");
/* harmony import */ var _win_routing_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./win-routing.module */ "gC2w");
/* harmony import */ var _win_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./win.page */ "WSLa");
/* harmony import */ var _shared_shared_module__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../shared/shared.module */ "PCNd");








let WinPageModule = class WinPageModule {
};
WinPageModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["IonicModule"],
            _win_routing_module__WEBPACK_IMPORTED_MODULE_5__["WinPageRoutingModule"],
            _shared_shared_module__WEBPACK_IMPORTED_MODULE_7__["SharedModule"]
        ],
        declarations: [_win_page__WEBPACK_IMPORTED_MODULE_6__["WinPage"]]
    })
], WinPageModule);



/***/ })

}]);
//# sourceMappingURL=win-win-module.js.map