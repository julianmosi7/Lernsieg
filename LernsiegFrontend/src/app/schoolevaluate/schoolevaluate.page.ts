import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AlertController, ToastController } from '@ionic/angular';
import { SchoolDto } from 'src/models/schoolDto';

@Component({
  selector: 'app-schoolevaluate',
  templateUrl: './schoolevaluate.page.html',
  styleUrls: ['./schoolevaluate.page.scss'],
})
export class SchoolevaluatePage implements OnInit {
  school: SchoolDto;
  telephoneNr: string;
  hideSaveBtn: boolean = true;
  range: number = 1;

  constructor(private activatedRoute: ActivatedRoute, private location: Location,
              public toastController: ToastController, public alertController: AlertController) { }

  ngOnInit() {
    this.activatedRoute.paramMap.subscribe(x => {
      this.school = JSON.parse(x.get('school'));
      console.log(`schoolevaluate::${this.school.id}`);
    });
  }

  telephoneNrChanged(): void{
    console.log(this.telephoneNr);
    this.hideSaveBtn = false;
    if(this.telephoneNr.length <= 7) this.hideSaveBtn = true;
  }

  saveBtnClick(): void{
    if(this.range == 1){
      this.presentAlert();
    }else{
      this.presentToast();
      this.location.back();
    }
  }

  async presentToast(){
    const toast = await this.toastController.create({
      message: 'Bewertung gespeichert',
      duration: 2000
    });
    toast.present();
  }

  async presentAlert(){
    const alert = await this.alertController.create({
      header: 'Achtung',
      message: 'Du hast noch keine Bewertung abgegeben',
      buttons: ['Cancel', 'OK']
    });

    await alert.present();
  }
}
