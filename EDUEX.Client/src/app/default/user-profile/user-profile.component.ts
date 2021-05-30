import { Component, OnInit } from '@angular/core';
import { IUserWithWebinars } from 'src/app/models/IUserWithWebinars';
import { UserWithWebinar } from 'src/app/models/UserWithWebinar';
import { AuthenticationService } from 'src/app/services/authentication.service';
import { SharedDataService } from 'src/app/services/share-data.service';
import { UserService } from 'src/app/services/user.service';
import { DateHelper } from '../shared/data-helper.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.scss']
})
export class UserProfileComponent implements OnInit {

  private user: IUserWithWebinars = new UserWithWebinar();
  private age: number;
  private isAlreadyPassed = DateHelper.isAlreadyPassed;

  constructor(private userService: UserService, private authService: AuthenticationService, private sharedService: SharedDataService) { }

  ngOnInit() {

    this.userService.getCurrentUser()
      .subscribe(data => {
        var id = data.id;
        this.userService.getUserWithWebinars(id)
          .subscribe(userWithWebs => {
            this.user = userWithWebs;
            this.age = DateHelper.calculateAge(this.user.birthDate)

            this.sharedService.emitChange('Профіль \'' + userWithWebs.firstName + ' ' + userWithWebs.lastName + '\'');
          })
      });

  }

  logOut(){
    this.authService.logOutUser();
  }

}
