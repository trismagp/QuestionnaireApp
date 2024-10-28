import { Component, effect, inject, OnInit, signal } from '@angular/core';
import { RegisterComponent } from "../register/register.component";
import { Questionnaire } from '../_models/questionnaire';
import { QuestionnairesService } from '../_services/questionnaires.service';
import { QuestionnaireListComponent } from '../questionnaires/questionnaire-list/questionnaire-list.component';


@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RegisterComponent,QuestionnaireListComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit{
  questionnairesService = inject(QuestionnairesService)
  questionnaires : Questionnaire[]=[];
  registerMode = false;

  constructor() {
    effect(() => {
      this.questionnaires= this.questionnairesService.questionnaires();
    });
  }
  
  ngOnInit(): void {
   
    if (this.questionnairesService.questionnaires().length == 0) this.loadQuestionnaires();

  }
  
  
  registerToggle() {
    this.registerMode = !this.registerMode
  }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }


  loadQuestionnaires(){
    this.questionnairesService.getQuestionnaires();
    
  }

 
  
}
