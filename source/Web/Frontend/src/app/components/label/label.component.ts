@Component({
    selector: "app-label",
    templateUrl: "./label.component.html"
})
export class AppLabelComponent {
    @Input()
    for!: string;
    @Input()
    text!: string;
}
