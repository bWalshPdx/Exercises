import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {

  output: string[];

  constructor() {
    this.output = {} as string[];
  }

  ngOnInit() {
  }

  //2019.07.08.05.51.14PM TODO:  Write a test for this first
  // getFizzBuzz(): string[] {

  // }

}
