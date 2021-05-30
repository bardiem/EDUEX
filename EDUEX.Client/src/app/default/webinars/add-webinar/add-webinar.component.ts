import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { SessionService } from 'src/app/services/session.service';
import { SharedDataService } from 'src/app/services/share-data.service';
import { UserService } from 'src/app/services/user.service';
import { WebinarService } from 'src/app/services/webinar.service';
import { parseError } from '../../shared/error-parser.service';

@Component({
  selector: 'app-add-webinar',
  templateUrl: './add-webinar.component.html',
  styleUrls: ['./add-webinar.component.scss']
})
export class AddWebinarComponent implements OnInit {
  userId: number;
  errorMsgs: string[] = [];
  successMessage: string = "";
  selectedDifficulty: number = 0;

  constructor(
    private webinarService: WebinarService, 
    private sessionService: SessionService, 
    private userService: UserService,
    private sharedService: SharedDataService) { }

  ngOnInit() {
    this.sharedService.emitChange('Додавання вебінару');

    this.userService.getCurrentUser()
      .subscribe(currentUser=> this.userId = currentUser.id);
  }

  onSubmit(form: NgForm){

    form.value.userId = this.userId;
    form.value.level = parseInt(form.value.level);
    form.value.price = parseFloat(form.value.price);
    console.log(form.value)
    
    this.webinarService.postWebinar(form.value)
      .subscribe(webinar => {
        this.showSuccessBlock();
        form.resetForm();
      }, 
      error => this.errorMsgs = parseError(error)
    );

  }

  showSuccessBlock(){
    this.successMessage = "Вебінар було створено успішно.";
    this.errorMsgs = [];
    setTimeout(() => this.successMessage = "", 4000);
  }
  
}
