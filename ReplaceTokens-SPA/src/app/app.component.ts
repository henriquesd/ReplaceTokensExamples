import { Component } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ReplaceTokens-SPA';

  public apiUrlServiceA: string = environment.serviceA.apiUrl;
  public apiUrlServiceB: string = environment.serviceB.apiUrl;

}
