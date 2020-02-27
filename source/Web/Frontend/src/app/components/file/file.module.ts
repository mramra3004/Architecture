import { AppFileComponent } from "./file.component";

@NgModule({
    declarations: [
        AppFileComponent
    ],
    exports: [
        AppFileComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule
    ]
})
export class AppFileModule {
}
