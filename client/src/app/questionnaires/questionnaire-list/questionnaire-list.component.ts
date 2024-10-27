import { Component, input } from '@angular/core';
import { Questionnaire } from '../../_models/questionnaire';

@Component({
  selector: 'app-questionnaire-list',
  standalone: true,
  imports: [],
  templateUrl: './questionnaire-list.component.html',
  styleUrl: './questionnaire-list.component.css'
})
export class QuestionnaireListComponent {
  questionnaires = input.required<Questionnaire[]>();
}
