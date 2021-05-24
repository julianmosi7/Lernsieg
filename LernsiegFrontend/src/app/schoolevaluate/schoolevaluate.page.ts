import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AlertController, ToastController } from '@ionic/angular';
import { CriteriaDto } from 'src/models/criteriaDto';
import { CriteriaEvaluatedDto } from 'src/models/criteriaEvaluatedDto';
import { EvaluationDto } from 'src/models/evaluationDto';
import { EvaluationSaveDto } from 'src/models/evaluationSaveDto';
import { SchoolDto } from 'src/models/schoolDto';
import { LernsiegService } from '../core/lernsieg.service';

@Component({
  selector: 'app-schoolevaluate',
  templateUrl: './schoolevaluate.page.html',
  styleUrls: ['./schoolevaluate.page.scss'],
})
export class SchoolevaluatePage implements OnInit {
  school: SchoolDto;
  telephoneNr: string;
  hideSaveBtn: boolean = true;
  criteriaEvaluations: CriteriaEvaluatedDto[] = [];
  evaluation: EvaluationDto;

  constructor(private activatedRoute: ActivatedRoute, private location: Location,
              public toastController: ToastController, public alertController: AlertController,
              public lernsiegService: LernsiegService) { }

  ngOnInit() {
    this.activatedRoute.paramMap.subscribe(x => {
      this.school = JSON.parse(x.get('school'));
      console.log(`schoolevaluate::${this.school.id}`);
    });
    this.lernsiegService.getCriterias(1).subscribe(x => {
      this.criteriaEvaluations = x.map(x=>{
        const item = new CriteriaEvaluatedDto();
        item.value = 0;
        item.sequenceNr = x.sequenceNr;
        item.description = x.description;
        item.id = x.id;
        return item;
      });
    })
  }

  telephoneNrChanged(): void{
    this.hideSaveBtn = false;
    if(this.telephoneNr.length <= 7) this.hideSaveBtn = true;
  }

  saveBtnClick(): void{
    const evaluationSaveDto = new EvaluationSaveDto();
    evaluationSaveDto.schoolOrTeacherId = this.school.id;
    evaluationSaveDto.evaluationType = 1;
    evaluationSaveDto.phoneNr = this.telephoneNr;
    evaluationSaveDto.evaluationItems = this.criteriaEvaluations;

    this.lernsiegService.saveEvaluation(evaluationSaveDto).subscribe(x => {
      this.evaluation = x;
      console.log("evaluation sent");
      console.log(x);
    });
    
    this.presentToast();
    this.location.back();
  }

  async presentToast(){
    const toast = await this.toastController.create({
      message: 'Bewertung gespeichert!',
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
