import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { SharedDataService } from 'src/app/services/share-data.service';
import { UserService } from 'src/app/services/user.service';
import { parseError } from '../shared/error-parser.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})

export class RegisterComponent implements OnInit {
  private isTeacher: boolean = false;
  private errorMsgs = [];
  private successMessage = "";

  constructor(private userService: UserService, private sharedService: SharedDataService) { }

  ngOnInit() {
    this.sharedService.emitChange('Реєстрація');
  }

  onSubmit(form: NgForm){
    if(form.value.birthDate == []){
      form.value.birthDate = null;
    }

    this.userService.postUser(form.value)
      .subscribe(
        success => {
          this.showSuccessBlock();
          form.resetForm();
        },
        error => this.errorMsgs = parseError(error)
      );

  }

  showSuccessBlock(){
    this.successMessage = "Реєстрація пройшла успішно.";
    this.errorMsgs = [];
    setTimeout(() => this.successMessage = "", 5000);
  }

}
