import { BrowserModule } from "@angular/platform-browser";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { HttpModule } from "@angular/http";

import {
  MaterialModule,
  MdToolbarModule,
  MdIconModule,
  MdMenuModule,
  MdGridListModule,
  MdCardModule,
  MdListModule
} from "@angular/material";

import { RecipeDetailComponent } from "./recipe-detail.component";
import { AppComponent } from "./app.component";
import { RecipeService } from "./recipe.service";
import { RecipeComponent } from "./recipe.component";

import { DashboardComponent } from "./dashboard.component";
import { AppRoutingModule } from "./app-routing.module";

@NgModule({
  declarations: [
    AppComponent,
    RecipeComponent,
    RecipeDetailComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpModule,
    MaterialModule,
    MdToolbarModule,
    MdMenuModule,
    MdGridListModule,
    MdCardModule,
    MdListModule,
    AppRoutingModule
  ],
  providers: [RecipeService],
  bootstrap: [AppComponent]
})
export class AppModule {}
