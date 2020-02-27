@Component({
    selector: "app-button",
    templateUrl: "./button.component.html"
})
export class AppButtonComponent {
    @Input()
    disabled = false;
    @Input()
    text!: string;
}
