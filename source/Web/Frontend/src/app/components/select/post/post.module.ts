import { AppSelectPostComponent } from "./post.component";

@NgModule({
    declarations: [
        AppSelectPostComponent
    ],
    exports: [
        AppSelectPostComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule
    ]
})
export class AppSelectPostModule {
}
