// Copyright 2006 Gokhan Altinoren - http://altinoren.com/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Altinoren.ActiveWriter.ToolWindow
{
    using System.Windows.Forms;
    using System;
    
    internal class KeyTypeComboBoxCell : DataGridViewComboBoxCell
    {
        private ObjectCollection collection;
        
        public override ObjectCollection Items
        {
            get
            {
                if (collection == null)
                {
                    collection = new ObjectCollection(this);
                    collection.AddRange(Enum.GetNames(typeof(KeyType)));
                }

                return collection;
            }
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            ComboBox editingControl = base.DataGridView.EditingControl as ComboBox;
            if (editingControl != null)
            {
                editingControl.Items.Clear();
                editingControl.Items.AddRange(Enum.GetNames(typeof(KeyType)));

                string value = initialFormattedValue as string;
                if (value != null)
                    editingControl.Text = value;
            }
        }
    }
}
