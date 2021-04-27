import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { SchoolDto } from 'src/models/schoolDto';
import { TeacherDto } from 'src/models/teacherDto';
import { EvaluationDto } from 'src/models/evaluationDto';
import { CriteriaDto } from 'src/models/criteriaDto';
import { EvaluationSaveDto } from 'src/models/evaluationSaveDto';

@Injectable({
  providedIn: 'root'
})
export class LernsiegService {
  url = "http://localhost:5000/Lernsieg"

  constructor(private httpClient: HttpClient) { }

  getTopSchools(country: string): Observable<SchoolDto[]>{
    return this.httpClient.get<SchoolDto[]>(`${this.url}/TopSchools/${country}`);
  }

  findSchools(country: string, filter: string): Observable<SchoolDto[]>{
    return this.httpClient.get<SchoolDto[]>(`${this.url}/FindSchools/${country}/${filter}}`);
  }

  getSchool(id: number): Observable<SchoolDto>{
    return this.httpClient.get<SchoolDto>(`${this.url}/GetSchool/${id}`);
  }

  findTeachers(schoolId: number, filter: string): Observable<TeacherDto[]>{
    return this.httpClient.get<TeacherDto[]>(`${this.url}/FindTeachers/${schoolId}/${filter}`);
  }

  getTeacher(id: number): Observable<TeacherDto>{
    return this.httpClient.get<TeacherDto>(`${this.url}/GetTeacher/${id}`);
  }

  getEvaluations(schoolOrTeacherId: number, evaluationType: number): Observable<EvaluationDto[]>{
    return this.httpClient.get<EvaluationDto[]>(`${this.url}/Evaluations/${schoolOrTeacherId}/${evaluationType}`);
  }

  getCriterias(evaluationType: string): Observable<CriteriaDto[]>{
    return this.httpClient.get<CriteriaDto[]>(`${this.url}/Criterias/${evaluationType}`);
  }

  saveEvaluation(data: EvaluationSaveDto): Observable<EvaluationDto>{
    return this.httpClient.post<EvaluationDto>(`${this.url}/SaveEvaluation`, {data: data});
  }
}
