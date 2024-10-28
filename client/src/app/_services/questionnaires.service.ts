import { HttpClient } from '@angular/common/http';
import { inject, Injectable, signal } from '@angular/core';
import { environment } from '../../environments/environment';
import { Questionnaire } from '../_models/questionnaire';

@Injectable({
  providedIn: 'root'
})
export class QuestionnairesService {

  private http = inject(HttpClient);
  baseUrl = environment.apiUrl;
  questionnaires = signal<Questionnaire[]>([]);


  getQuestionnaires() {
    return this.http.get<Questionnaire[]>(this.baseUrl + 'questionnaires').subscribe({
      next: questionnaires => this.questionnaires.set(questionnaires)
    });
  }
}
