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

namespace Apache.Qpid.Proton.Client.Exceptions
{
   /// <summary>
   /// Thrown when the Client fails a connection due to idle timeout.
   /// </summary>
   public class ClientIdleTimeoutException : ClientIOException
   {
      /// <summary>
      /// Creates a new connection idle timeout exception.
      /// </summary>
      /// <param name="message">The message that describes the reason for the error</param>
      public ClientIdleTimeoutException(string message) : base(message)
      {
      }

      /// <summary>
      /// Creates a new connection idle timeout exception.
      /// </summary>
      /// <param name="message">The message that describes the reason for the error</param>
      /// <param name="innerException">An exception that further defines the reason for the error</param>
      public ClientIdleTimeoutException(string message, Exception innerException) : base(message, innerException)
      {
      }
   }
}