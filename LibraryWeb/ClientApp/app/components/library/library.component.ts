import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'app-library',
    templateUrl: './library.component.html',
    styleUrls: ['./library.component.css']
})
/** library component*/
export class LibraryComponent {
    public library: Library[];
    /** library ctor */
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/Library').subscribe(result => {
            this.library = result.json() as Library[];
        }, error => console.error(error));
    }
}

interface Library {
    title: string;
    year: string;
    media: string;
    author: string;
    state: boolean;
}