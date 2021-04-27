(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["tipentry-tipentry-module"],{

/***/ "7RZb":
/*!*********************************************!*\
  !*** ./src/app/tipentry/tipentry.module.ts ***!
  \*********************************************/
/*! exports provided: TipentryPageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TipentryPageModule", function() { return TipentryPageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "SVse");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "s7LF");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "sZkV");
/* harmony import */ var _tipentry_routing_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./tipentry-routing.module */ "N+0x");
/* harmony import */ var _tipentry_page__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./tipentry.page */ "XGW/");
/* harmony import */ var _shared_shared_module__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../shared/shared.module */ "PCNd");








let TipentryPageModule = class TipentryPageModule {
};
TipentryPageModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
            _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["IonicModule"],
            _tipentry_routing_module__WEBPACK_IMPORTED_MODULE_5__["TipentryPageRoutingModule"],
            _shared_shared_module__WEBPACK_IMPORTED_MODULE_7__["SharedModule"]
        ],
        declarations: [_tipentry_page__WEBPACK_IMPORTED_MODULE_6__["TipentryPage"]]
    })
], TipentryPageModule);



/***/ }),

/***/ "N+0x":
/*!*****************************************************!*\
  !*** ./src/app/tipentry/tipentry-routing.module.ts ***!
  \*****************************************************/
/*! exports provided: TipentryPageRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TipentryPageRoutingModule", function() { return TipentryPageRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "iInd");
/* harmony import */ var _tipentry_page__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./tipentry.page */ "XGW/");




const routes = [
    {
        path: '',
        component: _tipentry_page__WEBPACK_IMPORTED_MODULE_3__["TipentryPage"]
    }
];
let TipentryPageRoutingModule = class TipentryPageRoutingModule {
};
TipentryPageRoutingModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]],
    })
], TipentryPageRoutingModule);



/***/ }),

/***/ "S715":
/*!*********************************************!*\
  !*** ./src/app/tipentry/tipentry.page.scss ***!
  \*********************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJ0aXBlbnRyeS5wYWdlLnNjc3MifQ== */");

/***/ }),

/***/ "XGW/":
/*!*******************************************!*\
  !*** ./src/app/tipentry/tipentry.page.ts ***!
  \*******************************************/
/*! exports provided: TipentryPage */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TipentryPage", function() { return TipentryPage; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "mrSG");
/* harmony import */ var _raw_loader_tipentry_page_html__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! raw-loader!./tipentry.page.html */ "m/nE");
/* harmony import */ var _tipentry_page_scss__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./tipentry.page.scss */ "S715");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "8Y7J");
/* harmony import */ var _ionic_angular__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ionic/angular */ "sZkV");
/* harmony import */ var _core_lotto_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../core/lotto.service */ "28ja");
/* harmony import */ var _core_storage_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../core/storage.service */ "qRYv");







let TipentryPage = class TipentryPage {
    constructor(lottoService, storageService, toastController) {
        this.lottoService = lottoService;
        this.storageService = storageService;
        this.toastController = toastController;
        this.entry_list = [
            { value: null },
            { value: null },
            { value: null },
            { value: null },
            { value: null },
            { value: null },
        ];
        this.isNull = false;
    }
    ngOnInit() { }
    sendTip() {
        var user = this.storageService.get('currentUser');
        console.log(user.then(x => {
            this.user = { userName: x.userName, userId: x.userId, password: x.password };
            console.log(this.user);
        }).catch(x => this.presentToast('No user logged in!')));
        this.isNull = false;
        for (let index = 0; index < this.entry_list.length; index++) {
            if (this.entry_list[index].value == null || this.entry_list[index].value == 0) {
                this.isNull = true;
            }
        }
        if (!this.isNull) {
            this.entry_one = this.entry_list[0].value;
            this.entry_two = this.entry_list[1].value;
            this.entry_three = this.entry_list[2].value;
            this.entry_four = this.entry_list[3].value;
            this.entry_five = this.entry_list[4].value;
            this.entry_six = this.entry_list[5].value;
            this.lottoService
                .addTipp(this.user.userId, this.user.password, this.entry_one, this.entry_two, this.entry_three, this.entry_four, this.entry_five, this.entry_six)
                .subscribe((x) => {
                console.log(x);
                this.presentToast(x.msg);
            });
        }
        else {
            console.log('enter more numbers!');
        }
    }
    generateRandomTips() {
        this.entry_list.forEach(x => x.value = this.generateRandomNumber());
    }
    generateRandomNumber() {
        return Math.floor(Math.random() * 50 + 1);
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
TipentryPage.ctorParameters = () => [
    { type: _core_lotto_service__WEBPACK_IMPORTED_MODULE_5__["LottoService"] },
    { type: _core_storage_service__WEBPACK_IMPORTED_MODULE_6__["StorageService"] },
    { type: _ionic_angular__WEBPACK_IMPORTED_MODULE_4__["ToastController"] }
];
TipentryPage = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_3__["Component"])({
        selector: 'app-tipentry',
        template: _raw_loader_tipentry_page_html__WEBPACK_IMPORTED_MODULE_1__["default"],
        styles: [_tipentry_page_scss__WEBPACK_IMPORTED_MODULE_2__["default"]]
    })
], TipentryPage);



/***/ }),

/***/ "m/nE":
/*!***********************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/tipentry/tipentry.page.html ***!
  \***********************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<ion-header>\n  <ion-toolbar>\n    <ion-title>Tippeingabe</ion-title>\n  </ion-toolbar>\n</ion-header>\n\n<ion-content [fullscreen]=\"true\">\n  <ion-header collapse=\"condense\">\n    <ion-toolbar>\n      <ion-title size=\"large\">Tippeingabe</ion-title>\n    </ion-toolbar>\n  </ion-header>\n\n  <div id=\"container\">\n    <ion-card>\n      <ion-list>\n        <ion-item *ngFor=\"let entry of entry_list; let i = index\">\n          <ion-label>Zahl {{i+1}}: </ion-label>\n          <ion-input [(ngModel)]=\"entry.value\"></ion-input>\n        </ion-item>\n      </ion-list>\n    </ion-card>\n\n    <ion-button expand=\"full\" (click)=\"sendTip()\">Sende Tipp</ion-button>\n    <ion-button expand=\"full\" (click)=\"generateRandomTips()\">Zufallstipps erzeugen</ion-button>\n  </div>\n</ion-content>\n\n<ion-footer>\n  <ion-toolbar>\n    <navbar></navbar>\n  </ion-toolbar>\n</ion-footer>");

/***/ })

}]);
//# sourceMappingURL=tipentry-tipentry-module.js.map