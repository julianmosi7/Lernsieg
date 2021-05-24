import { CriteriaEvaluatedDto } from "./criteriaEvaluatedDto";

export class EvaluationSaveDto{
    schoolOrTeacherId: number;
    evaluationType: number;
    phoneNr: string;
    evaluationItems: CriteriaEvaluatedDto[];
}