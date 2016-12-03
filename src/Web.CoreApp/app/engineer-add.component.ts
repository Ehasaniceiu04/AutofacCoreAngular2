import { Component} from '@angular/core';
import { Engineer } from './engineer';

@Component({
    moduleId: module.id,
    selector: 'engineer-add',
    templateUrl: 'engineer-add.component.html',
    styleUrls: ['enginner-add.component.css']
})
export class EngineerAddComponent {
    name='Engineer Entry --- From engineer-add.componet'
     engineer = new Engineer();
}
