import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    constructor(private _httpService: Http) { }

    title: string = "My App"
    apiValues: string[] = [];

    ngOnInit() {
        this._httpService.get('/api/product').subscribe(values => {
            this.apiValues = values.json() as string[];
        });
    }
}
