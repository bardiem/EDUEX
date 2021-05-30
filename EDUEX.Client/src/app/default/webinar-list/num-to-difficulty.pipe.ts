import { Pipe, PipeTransform } from "@angular/core";

@Pipe({
  name: "numToDifficulty"
})
export class NumToDifficultyPipe implements PipeTransform {
  transform(value: 1 | 2 | 3): string {
    switch (value) {
      case 1:
        return "Легкий";
      case 2:
        return "Середній";
      case 3:
        return "Важкий";
      default:
        return "Помилка";
    }
  }
}