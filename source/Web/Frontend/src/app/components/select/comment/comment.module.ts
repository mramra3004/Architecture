import { AppSelectCommentComponent } from "./comment.component";

@NgModule({
    declarations: [
        AppSelectCommentComponent
    ],
    exports: [
        AppSelectCommentComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule
    ]
})
export class AppSelectCommentModule {
}
