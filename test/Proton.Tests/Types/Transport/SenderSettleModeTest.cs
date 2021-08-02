/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using Apache.Qpid.Proton.Types.Transport;
using NUnit.Framework;

namespace Apache.Qpid.Proton.Types.Transactions
{
   [TestFixture]
   public class SenderSettleModeTest
   {
      [Test]
      public void TestValueOf()
      {
         Assert.AreEqual(SenderSettleMode.Unsettled, SenderSettleModeExtension.Lookup((byte)0));
         Assert.AreEqual(SenderSettleMode.Settled, SenderSettleModeExtension.Lookup((byte)1));
         Assert.AreEqual(SenderSettleMode.Mixed, SenderSettleModeExtension.Lookup((byte)2));
      }

      [Test]
      public void TestEquality()
      {
         SenderSettleMode unsettled = SenderSettleMode.Unsettled;
         SenderSettleMode settled = SenderSettleMode.Settled;
         SenderSettleMode mixed = SenderSettleMode.Mixed;

         Assert.AreEqual(unsettled, SenderSettleModeExtension.Lookup((byte)0));
         Assert.AreEqual(settled, SenderSettleModeExtension.Lookup((byte)1));
         Assert.AreEqual(mixed, SenderSettleModeExtension.Lookup((byte)2));

         Assert.AreEqual(unsettled.ByteValue(), (byte)0);
         Assert.AreEqual(settled.ByteValue(), (byte)1);
         Assert.AreEqual(mixed.ByteValue(), (byte)2);
      }

      [Test]
      public void TestNotEquality()
      {
         SenderSettleMode unsettled = SenderSettleMode.Unsettled;
         SenderSettleMode settled = SenderSettleMode.Settled;
         SenderSettleMode mixed = SenderSettleMode.Mixed;

         Assert.AreNotEqual(unsettled, SenderSettleModeExtension.Lookup((byte)2));
         Assert.AreNotEqual(settled, SenderSettleModeExtension.Lookup((byte)0));
         Assert.AreNotEqual(mixed, SenderSettleModeExtension.Lookup((byte)1));

         Assert.AreNotEqual(unsettled.ByteValue(), (byte)2);
         Assert.AreNotEqual(settled.ByteValue(), (byte)0);
         Assert.AreNotEqual(mixed.ByteValue(), (byte)1);
      }

      [Test]
      public void TestIllegalArgument()
      {
         Assert.Throws<ArgumentOutOfRangeException>(() => SenderSettleModeExtension.Lookup((byte)3));
      }

   }
}