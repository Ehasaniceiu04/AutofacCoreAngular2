import { Component } from '@angular/core';

@Component({
    selector: 'my-app',
    template: `<h1>Hello {{name}}</h1>
   <engineer-add></engineer-add>
`
})
export class AppComponent { name = 'Angular2 from app.component'; }
