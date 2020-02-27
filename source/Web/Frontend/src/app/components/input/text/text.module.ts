import { AppInputTextComponent } from "./text.component";

@NgModule({
    declarations: [
        AppInputTextComponent
    ],
    exports: [
        AppInputTextComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule
    ]
})
export class AppInputTextModule {
}
