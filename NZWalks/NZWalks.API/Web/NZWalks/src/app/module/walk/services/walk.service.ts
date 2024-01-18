import { Injectable } from '@angular/core';
import { BASE_URL } from '../../../app.config';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class WalkService {

  private baseUrl = `${BASE_URL}/api/walks`;

  constructor(private httpClient: HttpClient) { }

  getAll() {
    return this.httpClient.get(this.baseUrl);
  } 

  delete(id: number) {
    return this.httpClient.delete(`${this.baseUrl}/${id}`);
  }
}
