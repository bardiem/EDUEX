import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ISession } from 'src/app/models/ISession';
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

  sessions: ISession[] = [];
  userId: number;
  errorMsgs: string[] = [];
  successMessage: string = "";
  selectedDifficulty: number = 0;

  constructor(
    private webinarService: WebinarService, 
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
    form.value.sessions = this.sessions;
    
    this.webinarService.postWebinarWithSessions(form.value)
      .subscribe(success => {
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
