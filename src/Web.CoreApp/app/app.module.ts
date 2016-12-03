import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import {AppComponent} from './app.component';
import {EngineerAddComponent} from './engineer-add.component';

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [AppComponent, EngineerAddComponent],
    bootstrap: [AppComponent, EngineerAddComponent]
}
)
export class AppModule {
}