import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MainComponent } from './main.component';
import { DebugElement } from '@angular/core';

describe('MainComponent', () => {
  let component: MainComponent;
  let fixture: ComponentFixture<MainComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MainComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should render title in a h1 tag', () => {
    const fixture = TestBed.createComponent(MainComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    const selectedThing = compiled.querySelector('h1').textContent;
    expect(selectedThing).toContain('FizzBuzz Kata');
  });

  it('should render a collction of 1 through 5', () => {
    const fixture: ComponentFixture<MainComponent> = TestBed.createComponent(MainComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    const selectedThing = compiled.querySelector('#output').textContent;
    console.log(selectedThing);
    expect(selectedThing).toContain('12Fizz4Buzz');
  });

});
