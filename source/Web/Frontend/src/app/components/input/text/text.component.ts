import { AppInputComponent } from "../input.component";

@Component({
    providers: [{ provide: NG_VALUE_ACCESSOR, useExisting: AppInputTextComponent, multi: true }],
    selector: "app-input-text",
    templateUrl: "../input.component.html"
})
export class AppInputTextComponent extends AppInputComponent {
    constructor() {
        super("text");
    }
}
