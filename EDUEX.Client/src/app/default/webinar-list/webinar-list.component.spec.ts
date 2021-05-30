import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { WebinrListComponent } from './webinar-list.component';


describe('WebinrListComponent', () => {
  let component: WebinrListComponent;
  let fixture: ComponentFixture<WebinrListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [WebinrListComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WebinrListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
