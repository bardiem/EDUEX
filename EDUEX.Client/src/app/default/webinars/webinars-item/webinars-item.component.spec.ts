import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WebinarsItemComponent } from './webinars-item.component';

describe('WebinarsItemComponent', () => {
  let component: WebinarsItemComponent;
  let fixture: ComponentFixture<WebinarsItemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WebinarsItemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WebinarsItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
