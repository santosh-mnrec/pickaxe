﻿/* Copyright 2015 Brock Reeve
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Pickaxe.Sdk
{
    public interface IAstVisitor
    {
        void Visit(Program program);
        void Visit(FileTable table);
        void Visit(BufferTable table);
        void Visit(TableColumnArg arg);

        void Visit(InsertIntoStatement statement);
        void Visit(InsertOverwriteStatement statement);
        void Visit(InsertIntoDirectoryStatement statement);
        void Visit(SelectStatement statement);
        void Visit(SelectArg arg);
        void Visit(FromStatement statement);
        void Visit(WhereStatement statement);
        void Visit(PickStatement statement);
        void Visit(SelectId id);
        void Visit(SelectAll all);

        void Visit(ProxyStatement statement);
        void Visit(ProxyList list);

        void Visit(TakeAttributeStatement statement);
        void Visit(TakeTextStatement statement);
        void Visit(TakeHtmlStatement statement);

        void Visit(ExpandExpression expression);
        void Visit(ExpandIterationVariable variable);
        void Visit(DownloadPageExpression expression);
        void Visit(DownloadImageExpression expression);

        void Visit(EachStatement eachStatement);
        void Visit(Block block);

        void Visit(VariableReferance variable);
        void Visit(TableMemberReference variable);
        void Visit(TableVariableReference variable);
        void Visit(TableVariableRowReference variable);
        void Visit(TableVariableRowGetter variable);
        void Visit(StringLiteral literal);
        void Visit(IntegerLiteral literal);
        void Visit(NullLiteral literal);

        void Visit(VariableDeclarationStatement statement);
        
        void Visit(AdditionOperator op);
        void Visit(SubtrationOperator op);
        void Visit(MultiplicatonOperator op);
        void Visit(DivisionOperator op);

        void Visit(CaseVariableStatement statement);
        void Visit(WhenLiteralStatement statement);
        void Visit(CaseExpression statement);

        void Visit(CaseBooleanStatement statement);
        void Visit(WhenBooleanStatement statement);

        void Visit(LessThanExpression expression);
        void Visit(LessThanEqualExpression expression);
        void Visit(GreaterThanExpression expression);
        void Visit(GreaterThanEqualExpression expression);
        void Visit(NotEqualExpression expression);
        void Visit(EqualsExpression expression);

        void Visit(ProcedureDefinition definition);
        void Visit(ProcedureCall call);
    }
}
