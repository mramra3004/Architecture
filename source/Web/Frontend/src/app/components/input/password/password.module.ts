import { AppInputPasswordComponent } from "./password.component";

@NgModule({
    declarations: [
        AppInputPasswordComponent
    ],
    exports: [
        AppInputPasswordComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule
    ]
})
export class AppInputPasswordModule {
}
