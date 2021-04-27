(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["draws-draws-module"],{

/***/ "ECbR":
/*!*************************************!*\
  !*** ./src/app/draws/draws.page.ts ***!
  \*************************************/
/*! exports provided: DrawsPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DrawsPage", function() { return DrawsPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _raw_loader_draws_page_html__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! raw-loader!./draws.page.html */ "uG8d");
/* harmony import */ var _draws_page_scss__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./draws.page.scss */ "UfDV");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _core_lotto_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../core/lotto.service */ "28ja");





let DrawsPage = class DrawsPage {
    constructor(lottoService) {
        this.lottoService = lottoService;
        this.draws = [];
        this.rounds = [];
        this.wins = [];
    }
    ngOnInit() {
        this.lottoService.getCurrentRound().subscribe(x => {
            for (let index = 0; index < x.roundId; index++) {
                this.lottoService.getDrawnRoundData(index).subscribe(y => {
                    this.lottoService.getWinsOfRound(index).subscribe(z => {
                        if (z && y) {
                            this.draws.push({ round: y, win: z });
                        }
                    });
                });
            }
        });
    }
};
DrawsPage.ctorParameters = () => [
    { type: _core_lotto_service__WEBPACK_IMPORTED_MODULE_4__["LottoService"] }
];
DrawsPage = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_3__["Component"])({
        selector: 'app-draws',
        template: _raw_loader_draws_page_html__WEBPACK_IMPORTED_MODULE_1__["default"],
        styles: [_draws_page_scss__WEBPACK_IMPORTED_MODULE_2__["default"]]
    })
], DrawsPage);



/***/ }),

/***/ "UfDV":
/*!***************************************!*\
  !*** ./src/app/draws/draws.page.scss ***!
  \***************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJkcmF3cy5wYWdlLnNjc3MifQ== */");

/***/ }),

/***/ "qdU1":
/*!***********************************************!*\
  !*** ./src/app/draws/draws-routing.module.ts ***!
  \***********************************************/
/*! exports provided: DrawsPageRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DrawsPageRoutingModule", function() { return DrawsPageRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "iInd");
/* harmony import */ var _draws_page__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./draws.page */ "ECbR");




const routes = [
    {
        path: '',
        component: _draws_page__WEBPACK_IMPORTED_MODULE_3__["DrawsPage"]
    }
];
let DrawsPageRoutingModule = class DrawsPageRoutingModule {
};
DrawsPageRoutingModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]],
    })
], DrawsPageRoutingModule);



/***/ }),

/***/ "uG8d":
/*!*****************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/draws/draws.page.html ***!
  \*****************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<ion-header>\n  <ion-toolbar>\n    <ion-title>draws</ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content [fullscreen]=\"true\">\n  <ion-header collapse=\"condense\">\n    <ion-toolbar>\n      <ion-title size=\"large\">Ziehungen</ion-title>\n    </ion-toolbar>\n  </ion-header>\n\n  <div id=\"container\">\n    <ion-grid>\n      <ion-row>\n        <ion-col>Id</ion-col>\n        <ion-col>Ziehung</ion-col>\n        <ion-col>Z1</ion-col>\n        <ion-col>Z2</ion-col>\n        <ion-col>Z3</ion-col>\n        <ion-col>Z4</ion-col>\n        <ion-col>Z5</ion-col>\n        <ion-col>Z6</ion-col>\n        <ion-col>3er</ion-col>\n        <ion-col>4er</ion-col>\n        <ion-col>5er</ion-col>\n        <ion-col>6er</ion-col>\n      </ion-row>\n\n      <ion-row *ngFor=\"let draw of draws\">\n        <ion-col>{{draw.round.roundId}}</ion-col>\n        <ion-col>{{draw.round.finished}}</ion-col>\n        <ion-col [style.background-color]=\"'lightblue'\">{{draw.round.z1}}</ion-col>\n        <ion-col [style.background-color]=\"'lightblue'\">{{draw.round.z2}}</ion-col>\n        <ion-col [style.background-color]=\"'lightblue'\">{{draw.round.z3}}</ion-col>\n        <ion-col [style.background-color]=\"'lightblue'\">{{draw.round.z4}}</ion-col>\n        <ion-col [style.background-color]=\"'lightblue'\">{{draw.round.z5}}</ion-col>\n        <ion-col [style.background-color]=\"'lightblue'\">{{draw.round.z6}}</ion-col>\n        <ion-col [style.background-color]=\"draw.win.nr3 > 0 ? 'lightgreen' : ''\">{{draw.win.nr3}}</ion-col>\n        <ion-col [style.background-color]=\"draw.win.nr3 > 0 ? 'lightgreen' : ''\">{{draw.win.nr4}}</ion-col>\n        <ion-col [style.background-color]=\"draw.win.nr3 > 0 ? 'lightgreen' : ''\">{{draw.win.nr5}}</ion-col>\n        <ion-col [style.background-color]=\"draw.win.nr3 > 0 ? 'lightgreen' : ''\">{{draw.win.nr6}}</ion-col>\n      </ion-row>\n    </ion-grid>\n  </div>\n</ion-content>\n\n<ion-footer>\n  <ion-toolbar>\n    <navbar></navbar>\n  </ion-toolbar>\n</ion-footer>\n");

/***/ }),

/***/ "wEb3":
/*!***************************************!*\
  !*** ./src/app/draws/draws.module.ts ***!
  \***************************************/
/*! exports provided: DrawsPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DrawsPageModule", function() { return DrawsPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "SVse");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "s7LF");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "sZkV");
/* harmony import */ var _draws_routing_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./draws-routing.module */ "qdU1");
/* harmony import */ var _draws_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./draws.page */ "ECbR");
/* harmony import */ var _shared_shared_module__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../shared/shared.module */ "PCNd");








let DrawsPageModule = class DrawsPageModule {
};
DrawsPageModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["IonicModule"],
            _draws_routing_module__WEBPACK_IMPORTED_MODULE_5__["DrawsPageRoutingModule"],
            _shared_shared_module__WEBPACK_IMPORTED_MODULE_7__["SharedModule"]
        ],
        declarations: [_draws_page__WEBPACK_IMPORTED_MODULE_6__["DrawsPage"]]
    })
], DrawsPageModule);



/***/ })

}]);
//# sourceMappingURL=draws-draws-module.js.map