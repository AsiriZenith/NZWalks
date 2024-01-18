import { Region } from "../../region/models/region";
import { Difficulty } from "./difficulty";

export interface Walk {
  id: string;
  name: string;
  description: string;
  lengthInKm: number;
  walkImageUrl?: string;
  difficultyId: string;
  regionId: string;
  difficulty: Difficulty;
  region: Region;
}
