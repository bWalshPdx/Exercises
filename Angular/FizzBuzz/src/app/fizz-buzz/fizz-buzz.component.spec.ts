import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FizzBuzzComponent } from './fizz-buzz.component';

describe('FizzBuzzComponent', () => {
  let component: FizzBuzzComponent;
  let fixture: ComponentFixture<FizzBuzzComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FizzBuzzComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FizzBuzzComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('render 1 on label output1', () => {

    const fixture = TestBed.createComponent(FizzBuzzComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h1').textContent).toContain('Welcome to FizzBuzz!');
  });

  it('render Fizz on label output3', () => {

  });

  it('render Buzz on label output5', () => {

  });

  it('render FizzBuzz on label output15', () => {

  });

});
